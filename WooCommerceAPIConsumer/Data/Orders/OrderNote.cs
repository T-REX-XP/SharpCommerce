namespace SharpCommerce.Data.Orders
{
    using System;

    using Newtonsoft.Json;

    public class OrderNote
    {
        /// <summary>
        /// Order note ID [read-only]
        /// </summary>
        [JsonProperty("id")]
        public readonly int Id;

        /// <summary>
        /// UTC DateTime when the order note was created [read-only]
        /// </summary>
        [JsonProperty("created_at")]
        public readonly DateTime CreatedAt;

        /// <summary>
        /// Order note [required]
        /// </summary>
        [JsonProperty("note")]
        public string Note { get; set; }

        /// <summary>
        /// Shows/define if the note is only for reference or for the customer (the user will be notified). Default is 'false'
        /// </summary>
        [JsonProperty("customer_note")]
        public bool CustomerNote { get; set; }        
        
        /// <summary>
        /// Creates an Order Note C# object to hold the corresponding json object from 
        /// the wooCommerce v3 api. See http://woothemes.github.io/woocommerce-rest-api-docs/#create-a-note-for-an-order
        /// </summary>
        /// <param name="id">Order note id.</param>
        /// <param name="createdAt">Order note creation time.</param>
        /// <param name="note">The note text for the order not.</param>
        public OrderNote(string note, bool customerNote = false)
        {
            this.CustomerNote = customerNote;

            if (String.IsNullOrEmpty(note))
            {
                throw new ArgumentNullException("note", "A non empty value for 'note' is required.");
            }
            this.Note = note;
        }
    }
}
