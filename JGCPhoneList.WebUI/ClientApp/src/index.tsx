import React from 'react';
import ReactDOM from 'react-dom';

import configureStore from "./store";
import * as serviceWorker from './serviceWorker';
import App from './App';

var store = configureStore();
ReactDOM.render(<App store={store} />, document.getElementById('root'));

serviceWorker.unregister();