function CounterAction({count, setCount}) {
    return (
      <div>
        <button onClick={() => setCount(count+1)}>Arttır</button>
        <button onClick={() => setCount(count-1)}>Azalt</button>
      </div>
    );
}

export default CounterAction;
