import {useEffect, useState} from 'react';
import axios from 'axios';
import {Link} from 'react-router-dom';

function Posts() {
    const [posts, setPosts] = useState([]);
    const [loading, setLoading] = useState([]);
    

    useEffect(() => {
        axios("https://jsonplaceholder.typicode.com/posts")
        .then(res => setPosts(res.data))
        .finally(() => setLoading(false))
    }, [])
    return (
        <div>
            <h1> Posts </h1>
            {loading && <div> Loading.... </div>}
            <ul>
                {
                    posts.map((post) => (
                        <li key={post.id}>
                            <Link to={`/post/${post.id}`}>{post.title}</Link>
                        </li>
                    ))
                }
                
                
            </ul>

        </div>
    )
}
export default Posts;