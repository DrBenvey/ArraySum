namespace ArraySumLibrary.ScalarAlgebra.Custom.Calendar
{
    public class WorkerCalendar
    {
        public string Name { get; set; }
        public TimeSpan ProductiveTime { get; set; }
        public TimeSpan Distractions { get; set; }
        public Int64 Cost { get; set; }

        /// <summary>
        /// unseve constructor
        /// </summary>
        /// <param name="productiveTime"></param>
        /// <param name="distractions"></param>
        /// <param name="cost"></param>
        /// <param name="name"></param>
        internal WorkerCalendar(            
            TimeSpan productiveTime,
            TimeSpan distractions,
            Int64 cost,
            string name
            )
        {
            ProductiveTime = productiveTime;
            Distractions = distractions;
            Name = name;
            Cost = cost;
        }

        /// <summary>
        /// save constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="productiveTime"></param>
        /// <param name="distractions"></param>
        /// <param name="cost"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public WorkerCalendar(
            string name,
            TimeSpan productiveTime,
            TimeSpan distractions,
            Int64 cost
        )
        {
            if (name == null) 
                throw new ArgumentNullException(nameof(Name));
            if (productiveTime<TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(nameof(ProductiveTime));            
            if (distractions < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException(nameof(Distractions));
            if (cost < 0)
                throw new ArgumentOutOfRangeException(nameof(Cost));
            ProductiveTime = productiveTime;
            Distractions = distractions;
            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"===\n{Name}\n---\nProductive: {ProductiveTime}\nDistractions: {Distractions}\nCost: {Cost}\n===";
        }

        public override bool Equals(object obj)
        {
            var item = obj as WorkerCalendar;

            if (item == null)
                return false;

            return (
                        Name==item.Name && 
                        ProductiveTime==item.ProductiveTime &&
                        Distractions==item.Distractions &&
                        Cost==item.Cost
                    );
        }

        public override int GetHashCode()
        {
            return $"{Name}{ProductiveTime}{Distractions}{Cost}".GetHashCode();
        }
    }
}
