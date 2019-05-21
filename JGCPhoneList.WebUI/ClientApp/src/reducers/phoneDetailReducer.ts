import { Reducer } from 'redux';

import { PhoneDetailActions, PhoneDetailActionTypes, } from '../actions/PhoneDetailActions';

export interface IPhoneDetail {
    phoneId: number,
    model: string,
    description: string,
    year: number,
    weight: number,
    battery: number,
    ram: number,
    storage: number,
    resolution: string,
    price: number,
    manufacturerId: number,
    manufacturerName: string,
    operativeSystemId: number,
    operativeSystemName: string,
}

export interface IPhoneDetailState {
    phoneDetail: IPhoneDetail[]
}


const initialPhoneDetailState: IPhoneDetailState = {
    phoneDetail: []
};


export const phoneDetailReducer: Reducer<IPhoneDetailState, PhoneDetailActions> = (
    state = initialPhoneDetailState,
    action
) => {
    switch (action.type) {
        case PhoneDetailActionTypes.GET: {
            return {
                ...state,
                phoneDetail: action.phoneDetail,
            };
        }
        default:
            return state;
    }
};