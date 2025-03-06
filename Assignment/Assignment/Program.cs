using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    using System;

    public class Program
    {
        static Room[] rooms = new Room[10];
        static int roomCount = 0;

        public static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("\n\n\n1. Add a room");
                Console.WriteLine("2. Display room list");
                Console.WriteLine("3. Display details of selected room");
                Console.WriteLine("4. Update room availability status");
                Console.WriteLine("5. Delete the room from list");
                Console.WriteLine("6. Find rooms based on capacity and availability");
                Console.WriteLine("7. Add participant to the room");
                Console.WriteLine("8. List participants in a given room");
                Console.WriteLine("9. Exit\n\n");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddRoom();
                        break;
                    case 2:
                        DisplayRoomList();
                        break;
                    case 3:
                        DisplayRoomDetails();
                        break;
                    case 4:
                        UpdateRoomAvailability();
                        break;
                    case 5:
                        DeleteRoom();
                        break;
                    case 6:
                        FindRooms();
                        break;
                    case 7:
                        AddParticipantToRoom();
                        break;
                    case 8:
                        ListParticipantsInRoom();
                        break;
                    case 9:
                        return;
                }
            }
        }

        static void AddRoom()
        {
            Console.WriteLine("Enter Room ID:");
            int roomId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Room Name:");
            string roomName = Console.ReadLine();

            Console.WriteLine("Enter Room Capacity:");
            int capacity = int.Parse(Console.ReadLine());

            rooms[roomCount++] = new Room(roomId, roomName, capacity);
        }

        static void DisplayRoomList()
        {
            Console.WriteLine("Room List:");
            for (int i = 0; i < roomCount; i++)
            {
                Console.WriteLine((i + 1) + ". " + rooms[i].RoomName);
            }
        }

        static void DisplayRoomDetails()
        {
            Console.WriteLine("Enter Room ID to view details:");
            int roomId = int.Parse(Console.ReadLine());

            Room room = GetRoomById(roomId);
            if (room != null)
            {
                room.DisplayDetails();
            }
            else
            {
                Console.WriteLine("Room not found.");
            }
        }

        static void UpdateRoomAvailability()
        {
            Console.WriteLine("Enter Room ID to update availability:");
            int roomId = int.Parse(Console.ReadLine());

            Room room = GetRoomById(roomId);
            if (room != null)
            {
                room.UpdateAvailability();
            }
            else
            {
                Console.WriteLine("Room not found.");
            }
        }

        static void DeleteRoom()
        {
            Console.WriteLine("Enter Room ID to delete:");
            int roomId = int.Parse(Console.ReadLine());

            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i].RoomId == roomId)
                {
                    for (int j = i; j < roomCount - 1; j++)
                    {
                        rooms[j] = rooms[j + 1];
                    }
                    roomCount--;
                    Console.WriteLine("Room deleted.");
                    return;
                }
            }

            Console.WriteLine("Room not found.");
        }

        static void FindRooms()
        {
            Console.WriteLine("Enter minimum capacity:");
            int capacity = int.Parse(Console.ReadLine());

            Console.WriteLine("Only available rooms? (yes/no):");
            string onlyAvailable = Console.ReadLine().ToLower();

            Console.WriteLine("Rooms found:");
            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i].Capacity >= capacity &&
                    (onlyAvailable == "no" || rooms[i].IsAvailable))
                {
                    Console.WriteLine(rooms[i].RoomName);
                }
            }
        }

        static void AddParticipantToRoom()
        {
            Console.WriteLine("Enter Room ID to add participant:");
            int roomId = int.Parse(Console.ReadLine());

            Room room = GetRoomById(roomId);
            if (room != null)
            {
                Console.WriteLine("Enter Participant ID:");
                int participantId = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Participant Name:");
                string participantName = Console.ReadLine();

                Participant participant = new Participant(participantId, participantName);
                room.AddParticipant(participant);
            }
            else
            {
                Console.WriteLine("Room not found.");
            }
        }

        static void ListParticipantsInRoom()
        {
            Console.WriteLine("Enter Room ID to list participants:");
            int roomId = int.Parse(Console.ReadLine());

            Room room = GetRoomById(roomId);
            if (room != null)
            {
                room.ListParticipants();
            }
            else
            {
                Console.WriteLine("Room not found.");
            }
        }

        static Room GetRoomById(int roomId)
        {
            for (int i = 0; i < roomCount; i++)
            {
                if (rooms[i].RoomId == roomId)
                {
                    return rooms[i];
                }
            }
            return null;
        }
    }
}
