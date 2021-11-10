import {useState, useEffect} from 'react'
import axios from 'axios'
import {Link} from 'react-router-dom'


function Image() {

    const [items, setItems] = useState([]);
    
        
    useEffect(() => {
        axios.get("https://jsonplaceholder.typicode.com/photos")
        .then(res => setItems(res.data))
        
    }, [])

    return (
        <>
        <h1>Images and Images Link</h1>
        <hr/>
        {
         items.map((item) => (
            
        <li key={item.id}>
            <img src={item.thumbnailUrl} className="flex-auto mr-4" width="200" height="200" /><br/> <br/>
            <a href={item.thumbnailUrl}> {item.thumbnailUrl}</a>
        </li>
        ))}       
        </>
    );
}

export default Image;