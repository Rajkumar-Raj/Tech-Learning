import React from 'react';

const MyButton = (props) => {

    // const handleclick = () => {
    //     props.onclick();
    //   };
    
    return (<button onClick={props.onclick}>I'm a button clicked {props.count} </button>);
}

export default MyButton;