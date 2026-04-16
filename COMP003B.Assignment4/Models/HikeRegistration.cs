using System.ComponentModel.DataAnnotations;

namespace COMP003B.Assignment4.Models
{
	public class HikeRegistration
	{
		public int Id { get; set; }

		[Required]
		[StringLength(50)]
		public string FullName { get; set; } = string.Empty;

		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;

		[Range(1, 20)]
		public int GroupSize { get; set; }

		[Required]
		public int TrailId { get; set; }

		[StringLength(100)]
		public string Notes { get; set; } = string.Empty;
	}
}
