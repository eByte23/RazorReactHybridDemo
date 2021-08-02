import React, { useEffect, useState } from "react";

type TodoItem = {
  id: string;
  title: string;
  assignedUserId: string;
  complete?: boolean;
};

type User = {
  id: string;
  firstName: string;
  lastName: string;
  name: string;
};

interface TodoAppProps {
  users: User[];
  todoItems: TodoItem[];
}

export const TodoApp = ({ todoItems, users }: TodoAppProps) => {
  return (
    <div>
      <h1>Todo</h1>
      <div>
        <ul>
          {todoItems.map((todoItem) => (
            <li key={todoItem.id}>
              <div>
                <span>{todoItem.title}</span>
                {" - "}
                <span>
                  <b>
                    (
                    {todoItem.assignedUserId
                      ? users.find((u) => u.id === todoItem.assignedUserId).name
                      : "Unassigned"}
                    )
                  </b>
                </span>
              </div>
            </li>
          ))}
        </ul>
      </div>
    </div>
  );
};

export default TodoApp;
