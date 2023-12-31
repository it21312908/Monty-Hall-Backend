using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace test_backend.Models
{
	public class MontyHallGameResult
	{
		[Key]
		public int Id { get; set; }
		public int SelectedDoor { get; set; }
		public bool ShouldSwitch { get; set; }
		public bool PlayerWins { get; set; }
		public DateTime Timestamp { get; set; }
	}
}
