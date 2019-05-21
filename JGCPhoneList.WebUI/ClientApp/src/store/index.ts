import { applyMiddleware, combineReducers, createStore, Store } from 'redux';

import thunk from 'redux-thunk';

import { phoneReducer, IPhoneState, } from '../reducers/phoneReducer';
import { phoneDetailReducer, IPhoneDetailState, } from '../reducers/phoneDetailReducer';


export interface IAppState {
    phoneState: IPhoneState;
    phoneDetailState: IPhoneDetailState;
}

const rootReducer = combineReducers<IAppState>({
    phoneState: phoneReducer,
    phoneDetailState: phoneDetailReducer,
});

export default function configureStore(): Store<IAppState, any> {
    const store = createStore(rootReducer, undefined, applyMiddleware(thunk));
    return store;
}