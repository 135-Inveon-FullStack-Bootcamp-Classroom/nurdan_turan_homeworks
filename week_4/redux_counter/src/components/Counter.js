import {useSelector} from 'react-redux';
function Counter() {

  const count =UseSelector(state => state.count.value);
  
    return (
      <div>
        {count}
      </div>
    );
}

export default Counter;
