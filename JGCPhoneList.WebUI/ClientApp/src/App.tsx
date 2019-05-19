import React from 'react';
import { Provider } from "react-redux";
import { Store } from 'redux';
import { BrowserRouter } from 'react-router-dom'
import Home from './components/Home';
import Layout from './components/Layout';

interface AppProps {
    store: Store<any>;
}

//const store = configureStore();
class App extends React.Component<AppProps, {}> {
    render() {
        const { store } = this.props;
        return (
            <Provider store={store}>
                <BrowserRouter>
                    <Layout>
                        <Home />
                    </Layout>
                </BrowserRouter>
            </Provider>);
    }
}

export default App;