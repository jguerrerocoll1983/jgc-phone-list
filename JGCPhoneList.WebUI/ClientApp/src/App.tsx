import React from 'react';
import { BrowserRouter, Switch, Route } from 'react-router-dom'
import Home from './components/Home';
import PhoneList from './containers/PhoneList';
import Layout from './components/Layout';
// Import the store function and state

const App: React.SFC<{}> = () => {
    return (
        <>
            <BrowserRouter>
                <Layout>
                    <Switch>
                        <Route exact path='/' component={Home} />
                        <Route path='/Phones' component={PhoneList} />
                    </Switch>
                </Layout>
            </BrowserRouter>
        </>
    );
};

export default App;