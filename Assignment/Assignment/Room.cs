using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public Participant[] Participants { get; set; }
        public int ParticipantCount { get; set; }

        public Room(int roomId, string roomName, int capacity)
        {
            RoomId = roomId;
            RoomName = roomName;
            Capacity = capacity;
            IsAvailable = true;
            Participants = new Participant[capacity];
            ParticipantCount = 0;
        }

        public void AddParticipant(Participant participant)
        {
            if (ParticipantCount < Capacity)
            {
                Participants[ParticipantCount++] = participant;
            }
            else
            {
                Console.WriteLine("Room is full.");
            }
        }

        public void ListParticipants()
        {
            Console.WriteLine("Participants in room " + RoomName + ":");
            for (int i = 0; i < ParticipantCount; i++)
            {
                Console.WriteLine((i + 1) + ". " + Participants[i].PersonName);
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Room ID: " + RoomId);
            Console.WriteLine("Room Name: " + RoomName);
            Console.WriteLine("Capacity: " + Capacity);
            Console.WriteLine("Available: " + (IsAvailable ? "Yes" : "No"));
        }

        public void UpdateAvailability()
        {
            IsAvailable = !IsAvailable;
            Console.WriteLine("Room availability updated.");
        }
    }

}
