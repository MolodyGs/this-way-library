// using System;
// using System.Collections.Generic;
// using UnityEngine;

// public class PriorityQueue<T>
// {
//   private List<(T item, int priority)> heap = new List<(T, int)>();

//   public int Count => heap.Count;

//   public void Enqueue(T item, int priority)
//   {
//     heap.Add((item, priority));
//     HeapifyUp(heap.Count - 1);
//   }

//   public T Dequeue()
//   {
//     if (heap.Count == 0) return default;
//     T item = heap[0].item;
//     Debug.Log("El mejor item es: " + item);
//     heap[0] = heap[^1];  // Mueve el último al inicio
//     heap.RemoveAt(heap.Count - 1);
//     HeapifyDown(0);
//     return item;
//   }

//   private void HeapifyUp(int index)
//   {
//     while (index > 0)
//     {
//       int parentIndex = (index - 1) / 2;
//       if (heap[parentIndex].priority <= heap[index].priority) break;
//       (heap[parentIndex], heap[index]) = (heap[index], heap[parentIndex]);
//       index = parentIndex;
//     }
//   }

//   private void HeapifyDown(int index)
//   {
//     while (true)
//     {
//       int left = index * 2 + 1;
//       int right = index * 2 + 2;
//       int smallest = index;

//       if (left < heap.Count && heap[left].priority < heap[smallest].priority)
//         smallest = left;
//       if (right < heap.Count && heap[right].priority < heap[smallest].priority)
//         smallest = right;
//       if (smallest == index) break;

//       (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
//       index = smallest;
//     }
//   }
// }