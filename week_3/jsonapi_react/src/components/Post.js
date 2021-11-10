import {useEffect, useState} from 'react';
import axios from 'axios';
import {Link, useParams} from 'react-router-dom';

function Post() {
    const [post, setPost] = useState({});
    const {id} = useParams();
    const [loading, setLoading] = useState([]);

    useEffect(() => {
        axios(`https://jsonplaceholder.typicode.com/posts/${id}`)
        .then(res =>setPost(res.data))
        .finally(() => setLoading(false));     
    }, [id]) //id güncelleme yapma amaçlı gondeririz

    return (
        <div>
           <h1>Post Details</h1>
           {loading && <div> Loading.... </div>}
           {!loading && <code> { JSON.stringify(post)} </code>}
           <br/><br/><br/>
           <Link to={`/post/${parseInt(id) + 1}`}>Next Post ({parseInt(id) + 1}) </Link>
                                 
        </div>
    )
}

export default Post;
