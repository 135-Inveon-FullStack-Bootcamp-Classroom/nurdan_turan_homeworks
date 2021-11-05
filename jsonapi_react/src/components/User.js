import {useEffect, useState} from 'react';
import axios from 'axios';
import {Link, useParams} from 'react-router-dom';

function User() {
    const [user, setUser] = useState({});
    const {id} = useParams();
    const [loading, setLoading] = useState([]);

    useEffect(() => {
        axios(`https://jsonplaceholder.typicode.com/users/${id}`)
        .then(res =>setUser(res.data))
        .finally(() => setLoading(false));     
    }, [id]) //id güncelleme yapma amaçlı gondeririz

    return (
        <div className="textarea">
           <h1>User Details</h1>
           {loading && <div> Loading.... </div>}
           {!loading && <code> { JSON.stringify(user)} </code>}
           <br/><br/><br/>
           <Link to={`/user/${parseInt(id) + 1}`}>Next User ({parseInt(id) + 1}) </Link>
                                 
        </div>
    )
}

export default User;
