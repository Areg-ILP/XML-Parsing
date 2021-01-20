using System;
using System.ComponentModel.DataAnnotations;


namespace Testing_XML
{
    [Serializable]
    public class User
    {
        private Guid _id;
        private string _name;
        private string _surName;

        [Required]
        public string Id
        {
            get { return _id.ToString(); }
            set { _id = Guid.Parse(value); }
        }

        [Required(ErrorMessage = "User name not specified")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Symbol count of Name out of distance")]
        public string Name => _name;

        [Required(ErrorMessage = "User surname not specified")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Symbol count of SurName out of distance")]
        public string SurName => _surName;

        //for serialization
        public User() {}

        public User(string name,string surName)
        {
            _id = Guid.NewGuid();
            _name = name;
            _surName = surName;
        }
    }
}
