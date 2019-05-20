import { Reducer } from 'redux';
import {
    PhoneActions,
    PhoneActionTypes,
} from '../actions/PhoneActions';

export interface IPhone {
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

export interface IPhoneState {
    readonly phones: IPhone[];
}

const initialPhoneState: IPhoneState = {
    phones: [],
};

export const phoneReducer: Reducer<IPhoneState, PhoneActions> = (
    state = initialPhoneState,
    action
) => {
    switch (action.type) {
        case PhoneActionTypes.GET_ALL: {
            return {
                ...state,
                phones: action.phones,
            };
        }
        default:
            return state;
    }
};