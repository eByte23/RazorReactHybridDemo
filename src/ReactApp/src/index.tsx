import React from "react";
import ReactDOM from "react-dom";
import TodoApp from "./components/Todo";

export class RALib {

  // This is where you can register your components
  // after they have been imported.
  public components = {
    TodoApp,
  };

  render(component: any, container: any, props: any) {
    const Comp = this.components[component];
    const Props = Object.assign({}, props);
    ReactDOM.render(<Comp {...Props} />, container);
  }
}

const RALibInstance = new RALib();

// This is the object that will be export as 'ra'
export default RALibInstance;
