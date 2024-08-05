namespace KlassyCafe.Dtos.ReservationDtos
{
    public class GetReservationByIdDto
    {
        public int ReservationId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
        public string Hour { get; set; }
        public string MessageBody { get; set; }
    }
}
