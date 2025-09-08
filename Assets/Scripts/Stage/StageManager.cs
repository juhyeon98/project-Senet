using UnityEngine;
using System.Collections.Generic;

namespace Juhyeon.StageSystem
{
	public class StageManager : MonoBehaviour
	{
		#region Room Prefab
		public GameObject allOpenRoom;
		public GameObject oneWallRoom;
		public GameObject passageRoom;
		public GameObject twoWallRoom;
		public GameObject onePassRoom;
		#endregion
		
		#region Field
		private Room[,] m_maze = new Room[4, 4];
		private Vector2Int m_startRoomPosition;
		private Vector2Int m_exitRoomPosition;
		#endregion

		#region Method
		private void MakeMaze()
		{
			// initialize Room field
			for (int y = 0; y < 4; y++)
			{
				for (int x = 0; x < 4; x++)
				{
					m_maze[y, x] = new Room();
				}
			}
			for (int y = 0; y < 4; y++)
			{
				for (int x = 0; x < 4; x++)
				{
					if (x - 1 >= 0) m_maze[y, x].AddNeighborRoom(ERoomDirection.Left, m_maze[y, x - 1]);
					if (x + 1 < 4) m_maze[y, x].AddNeighborRoom(ERoomDirection.Right, m_maze[y, x + 1]);
					if (y - 1 >= 0) m_maze[y, x].AddNeighborRoom(ERoomDirection.Up, m_maze[y, x - 1]);
					if (y + 1 < 4) m_maze[y, x].AddNeighborRoom(ERoomDirection.Down, m_maze[y, x + 1]);
				}
			}
			
			// set start Room position
			m_startRoomPosition = new Vector2Int(Random.Range(0, 4) , Random.Range(0, 4));
			
			// set exit Room position
			if (m_startRoomPosition.x < 2 && m_startRoomPosition.y < 2) m_exitRoomPosition = new Vector2Int(Random.Range(2, 4), Random.Range(2, 4));
			else if (m_startRoomPosition.x < 2 && m_startRoomPosition.y >= 2)
				m_exitRoomPosition = new Vector2Int(Random.Range(2, 4), Random.Range(0, 2));
			else if (m_startRoomPosition.x >= 2 && m_startRoomPosition.y < 2) m_exitRoomPosition = new Vector2Int(Random.Range(0, 2), Random.Range(2, 4));
			else m_exitRoomPosition = new Vector2Int(Random.Range(0, 2), Random.Range(0, 2));
			
			// make maze by Prim algorithm
			List<Room> linkedRooms = new List<Room>();
			linkedRooms.Clear();
			linkedRooms.Add(m_maze[m_startRoomPosition.y, m_startRoomPosition.x]);

			int count = 16;
			while (count > 0)
			{
				var room = linkedRooms[Random.Range(0, linkedRooms.Count)];
				var neighbor = room.PickUpRoom();

				if (neighbor.room == null)
				{
					linkedRooms.Remove(room);
				}
				else if (!linkedRooms.Contains(neighbor.room))
				{
					linkedRooms.Add(neighbor.room);
					room.Open(neighbor.direction);
					count--;
				}
			}
			
		}
		#endregion
	}
}
