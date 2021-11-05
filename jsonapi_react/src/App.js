import React from "react";
import './App.css';
import User from "./components/User";
import Users from "./components/Users";
import Posts from "./components/Posts";
import Post from "./components/Post";
import Image from "./components/Image";

import {
  BrowserRouter as Router,
  Routes,
  Route,
  Link
} from "react-router-dom";

export default function App() {
  return (
    <div>
    <Router>
      <div>
        <nav>
          <ul>
            <li>
              <Link to="/">Home</Link>
            </li>
            <li>
              <Link to="/about">About</Link>
            </li>
            <li> <Link to="/users">Users</Link> </li>
            <li> <Link to="/user">User</Link> </li>
            <li> <Link to="/posts">Posts</Link> </li>
            <li> <Link to="/post">Post</Link> </li>
            <li> <Link to="/image">Image</Link> </li>
          </ul>
        </nav>

        <Routes>
          <Route path="/users" element={<Users />} />
          <Route path="/about" element={<About />} />
          <Route path="/image" element={<Image />} />
          <Route path="/user/:id" element={<User />} />
          <Route path="/posts" element={<Posts />} />
          <Route path="/post/:id" element={<Post />} />
          <Route path="/" element={<Home />} />
         </Routes>

      </div>
    </Router>
    </div>
  );
}

function Home() {
  return <h1>Home</h1>;
}

function About() {
  return <h2>About</h2>;
}
