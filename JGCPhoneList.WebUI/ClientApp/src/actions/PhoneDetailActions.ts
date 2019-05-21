import { ActionCreator, Dispatch } from 'redux';
import { ThunkAction } from 'redux-thunk';
import axios from 'axios';

import { IPhoneDetail, IPhoneDetailState } from '../reducers/phoneDetailReducer';

export enum PhoneDetailActionTypes {
    GET = 'GET',
}

export interface IPhoneDetailGetAction {
    type: PhoneDetailActionTypes.GET;
    phoneDetail: IPhoneDetail[];
}

/* 
Combine the action types with a union (we assume there are more)
example: export type PhoneActions = IGetAllAction | IGetOneAction ... 
*/
export type PhoneDetailActions = IPhoneDetailGetAction;

/* Get All Action
<Promise<Return Type>, State Interface, Type of Param, Type of Action> */
export const getPhoneDetail: ActionCreator<
    ThunkAction<Promise<any>, IPhoneDetailState, number, IPhoneDetailGetAction>
> = (param) => {
    return async (dispatch: Dispatch) => {
        try {
            const response = await axios.get('/Api/Phones/' + param);
            dispatch({
                phones: response.data.phoneListItems,
                type: PhoneDetailActionTypes.GET,
            });
        } catch (err) {
            console.error(err);
        }
    };
};