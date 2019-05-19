//import ReactDOM from 'react-dom';
//import configureStore from './store';

//import App from './App';
//import * as serviceWorker from './serviceWorker';

//const store = configureStore();
//const rootElement = document.getElementById('root');

//ReactDOM.render(App, rootElement);

import React from 'react';
import ReactDOM from 'react-dom';

import configureStore from "./store";
import * as serviceWorker from './serviceWorker';
import App from './App';

var store = configureStore();
ReactDOM.render(<App store={store} />, document.getElementById('root'));

serviceWorker.unregister();