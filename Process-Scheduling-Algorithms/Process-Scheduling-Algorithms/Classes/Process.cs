﻿namespace Process_Scheduling_Algorithms.Classes
{
    class Process
    {
        private static int _count;
        private int _priority;
        private int _burstTime;
        private int _arrivalTime;
        private string _name;
        public int LastEndTime { get; set; }
        public int WaitingTime { get; set; }
        public bool IsPlotted { get; set; }

        public int BurstTime
        {
            get { return this._burstTime; }
            set { this._burstTime = value < 0 ? 0 : value; }
        }

        public int ArrivalTime
        {
            get { return this._arrivalTime; }
            set { this._arrivalTime = value < 0 ? 0 : value; }
        }

        public int Priority
        {
            get { return this._priority; }
            set { this._priority = value < 0 ? 0 : value; }
        }

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        public Process(string name, int priority, int burstTime, int arrivalTime)
        {
            this.Name = name;
            this.Priority = priority;
            this.BurstTime = burstTime;
            this.ArrivalTime = arrivalTime;
        }

        public Process(int priority, int burstTime, int arrivalTime)
        {
            this.Name = string.Format("P{0}", _count++);
            this.Priority = priority;
            this.BurstTime = burstTime;
            this.ArrivalTime = arrivalTime;
        }

        public Process(string name, int burstTime, int arrivalTime)
        {
            this.Name = name;
            this.BurstTime = burstTime;
            this.ArrivalTime = arrivalTime;
        }

        public Process(string name, int burstTime)
        {
            this.Name = name;
            this.BurstTime = burstTime;
        }

        public int CompareToPriority(Process obj)
        {
            if (this.Priority > obj.Priority) return 1;
            if (this.Priority < obj.Priority) return -1;
            return 0;
        }

        public int CompareToBurstTime(Process obj)
        {
            if (this.BurstTime > obj.BurstTime) return 1;
            if (this.BurstTime < obj.BurstTime) return -1;
            return 0;
        }

        public int CompareToArrivalTime(Process obj)
        {
            if (this.ArrivalTime > obj.ArrivalTime) return 1;
            if (this.ArrivalTime < obj.ArrivalTime) return -1;
            return 0;
        }
    }
}
