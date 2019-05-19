import React from 'react';
import { Provider } from "react-redux";
import { Store } from 'redux';
import { BrowserRouter, Switch, Route } from 'react-router-dom'
import Home from './components/Home';
import Phones from './components/Phones';
import Layout from './components/Layout';

interface AppProps {
    store: Store<any>;
}

class App extends React.Component<AppProps, {}> {
    render() {
        const { store } = this.props;
        return (
            <Provider store={store}>
                <BrowserRouter>
                    <Layout>
                        <Switch>
                            <Route exact path='/' component={Home} />
                            <Route path='/Phones' component={Phones} />
                        </Switch>
                    </Layout>
                </BrowserRouter>
            </Provider>);
    }
}

export default App;