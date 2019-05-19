import { createStore, combineReducers } from "redux";
import { connectRouter } from "connected-react-router"
import { createBrowserHistory } from 'history';
var history = createBrowserHistory();

const rootReducer = combineReducers({ router: connectRouter(history) });

export type AppState = ReturnType<typeof rootReducer>;

export default function configureStore() {
    const store = createStore(
        rootReducer
    );

    return store;
}