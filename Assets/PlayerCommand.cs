using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCommand : MonoBehaviour
{
    ICommand right;
    ICommand left;
    ICommand forward;
    ICommand back;
    float timer;
    float cd = 0.5f;
    bool isActioning;

    Stack<ICommand> history = new Stack<ICommand>();
    Queue<ICommand> todo = new Queue<ICommand>();

    private void Start()
    {
        right = new MoveRight(this.transform);
        left = new MoveLeft(this.transform);
        forward = new MoveForward(this.transform);
        back = new MoveBackwards(this.transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            //right.Do();
            //history.Push(right);
            todo.Enqueue(right);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            //left.Do();
            //history.Push(left);
            todo.Enqueue(left);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            //forward.Do();
            //history.Push(forward);
            todo.Enqueue(forward);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            //back.Do();
            //history.Push(back);
            todo.Enqueue(back);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (history.Count <= 0) return;
            var commandpopped = history.Pop();
            commandpopped.UnDo();
        }


        
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (todo.Count <= 0) return;
            StartCoroutine(ToDoActions());
            
        }

        //if (isActioning)
        //{
        //    if (timer < cd)
        //    {
        //        timer = timer + 1 * Time.deltaTime;
        //    }
        //    else
        //    {
        //        todo.Dequeue().Do();
        //        timer = 0;
        //    }
        //}
    }

    IEnumerator ToDoActions()
    {
        while (true)
        {
            if (todo.Count <= 0) yield break;
            todo.Dequeue().Do();
            yield return new WaitForSeconds(0.5f);
        }
    }
}
