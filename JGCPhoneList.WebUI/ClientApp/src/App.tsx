import React, { Component } from 'react';
import { Provider } from "react-redux";
import { Store } from 'redux';
import { History } from "history"
import { ConnectedRouter } from 'connected-react-router';
import Home from './components/Home';
import Layout from './components/Layout';

interface AppProps {
    store: Store<any>;
    history: History;
}

//const store = configureStore();
class App extends React.Component<AppProps, {}> {
    render() {
        const { store, history } = this.props;
        return (
            <Provider store={store}>
                <ConnectedRouter history={history}>
                    <Layout>
                        <Home />
                    </Layout>
                </ConnectedRouter>
            </Provider>);
    }
}

export default App;