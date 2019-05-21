import * as React from 'react';
import * as ReactDOM from 'react-dom';

import { Provider } from 'react-redux';

import { Store } from 'redux';

import configureStore, { IAppState } from './store';
import { getAllPhones } from './actions/PhoneActions';

import App from './App';

import * as serviceWorker from './serviceWorker';


import 'bootstrap/dist/css/bootstrap.css';

interface IProps {
    store: Store<IAppState>;
}

const store = configureStore();
store.dispatch(getAllPhones());

/* 
Create a root component that receives the store via props
and wraps the App component with Provider, giving props to containers
*/
const Root: React.SFC<IProps> = props => {
    return (
        <Provider store={props.store}>
            <App />
        </Provider>
    );
};

ReactDOM.render(<Root store={store} />, document.getElementById(
    'root'
  ) as HTMLElement);

serviceWorker.unregister();