import * as React from 'react';
import { Route } from 'react-router-dom';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Games } from './components/Games';
import { About } from './components/About';

export const routes = <Layout>
    <Route exact path='/' component={ Home } />
    <Route path='/games' component={ Games} />
    <Route path='/about' component={ About } />
</Layout>;
