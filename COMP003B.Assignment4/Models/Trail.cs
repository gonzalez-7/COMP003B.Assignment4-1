using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
	public class Trail
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[StringLength(100)]
		public string Location { get; set; } = string.Empty;

		[Range(1, 30)]
		public double DistanceMiles { get; set; }

		[Required]
		[StringLength(20)]
		public string Difficulty { get; set; } = string.Empty;
	}
}
