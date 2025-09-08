using System.Collections.Generic;
using UnityEngine;

namespace Juhyeon.StageSystem
{
	public enum ERoomDirection
	{
		None = -1,
		Up = 0, Right, Down, Left
	}

	public class Room
	{
		#region Fields
		private bool b_visited;
		private Dictionary<ERoomDirection, Room> m_neighbors = new Dictionary<ERoomDirection, Room>();
		private Dictionary<ERoomDirection, Room> m_links = new Dictionary<ERoomDirection, Room>();
		#endregion

		#region Properties
		public bool Visited => b_visited;
		public Dictionary<ERoomDirection, Room> Neighbors => m_neighbors;
		#endregion
		
		#region Methods
		public Room()
		{
			b_visited = false;
			m_neighbors.Clear();
			m_links.Clear();
		}

		public void AddNeighborRoom(ERoomDirection direction, Room room) => m_neighbors.TryAdd(direction, room);

		public (ERoomDirection direction, Room room) PickUpRoom()
		{
			List<ERoomDirection> unvisitedDirections = new List<ERoomDirection>();
			unvisitedDirections.Clear();
			foreach (var item in m_neighbors)
			{
				if (!item.Value.b_visited)
				{
					unvisitedDirections.Add(item.Key);
				}
			}

			if (unvisitedDirections.Count == 0)
			{
				return (ERoomDirection.None, null);
			}
			
			var direction = unvisitedDirections[Random.Range(0, unvisitedDirections.Count)];
			return (direction, m_neighbors[direction]);
		}
		
		public void Open(ERoomDirection direction)
		{
			var room = m_neighbors[direction];
			m_neighbors.Remove(direction);
			m_links.Add(direction, room);

			b_visited = true;

			var neighborDirection = (ERoomDirection)(((int)direction + 2) % 4);
			room.m_neighbors.Remove(neighborDirection);
			room.m_links.Add(neighborDirection, this);

			room.b_visited = true;
		}
		#endregion
	}
}
