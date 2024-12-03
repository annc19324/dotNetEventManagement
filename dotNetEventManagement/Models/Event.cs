﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNetEventManagement.Models
{
    public class Event
    {
        public string EventId { get; set; } // ID sự kiện
        public string EventName { get; set; } // Tên sự kiện
        public string StartDate { get; set; } // Ngày bắt đầu
        public string EndDate { get; set; } // Ngày kết thúc
        public string Location { get; set; } // Địa điểm tổ chức
        public string Description { get; set; } // Mô tả chi tiết
        private string status; // Trạng thái của sự kiện
        public double Price { get; set; } // Giá vé

        // Constructors
        public Event() { }

        public Event(string eventId)
        {
            EventId = eventId;
        }

        public Event(string eventId, string eventName, string startDate, string endDate, string location, string description, string status, double price)
        {
            EventId = eventId;
            EventName = eventName;
            StartDate = startDate;
            EndDate = endDate;
            Location = location;
            Description = description;
            Status = status; // Sử dụng setter để kiểm tra giá trị
            Price = price;
        }

        // Property with validation for Status
        public string Status
        {
            get => status;
            set
            {
                if (value == "soon" || value == "active" || value == "expired")
                    status = value;
                else
                    throw new ArgumentException("Status must be 'soon', 'active', or 'expired'.");
            }
        }

        // ToString method
        public override string ToString()
        {
            return string.Format(
                "Event[ID={0}, Name='{1}', StartDate='{2}', EndDate='{3}', Location='{4}', Description='{5}', Status='{6}', Price={7:F2}]",
                EventId, EventName, StartDate, EndDate, Location, Description, Status, Price);
        }
    }

}