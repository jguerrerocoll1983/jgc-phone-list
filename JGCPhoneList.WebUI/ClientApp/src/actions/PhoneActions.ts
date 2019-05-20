import { ActionCreator, Dispatch } from 'redux';
import { ThunkAction } from 'redux-thunk';
import axios from 'axios';

import { IPhone, IPhoneState } from '../reducers/phoneReducer';

export enum PhoneActionTypes {
    GET_ALL = 'GET_ALL',
}

export interface IPhoneGetAllAction {
    type: PhoneActionTypes.GET_ALL;
    phones: IPhone[];
}

/* 
Combine the action types with a union (we assume there are more)
example: export type PhoneActions = IGetAllAction | IGetOneAction ... 
*/
export type PhoneActions = IPhoneGetAllAction;

/* Get All Action
<Promise<Return Type>, State Interface, Type of Param, Type of Action> */
export const getAllPhones: ActionCreator<
    ThunkAction<Promise<any>, IPhoneState, null, IPhoneGetAllAction>
> = () => {
    return async (dispatch: Dispatch) => {
        try {
            const response = await axios.get('/Api/Phones');
            dispatch({
                phones: response.data.phoneListItems,
                type: PhoneActionTypes.GET_ALL,
            });
        } catch (err) {
            console.error(err);
        }
    };
};