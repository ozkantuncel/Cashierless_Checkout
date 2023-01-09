using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cashierless_Checkout.firebase.dto
{
    [FirestoreData]
    public class Check
    {
        [FirestoreProperty]
        public string date { get; set; }
        [FirestoreProperty]
        public bool isChecked { get; set; }
    }
}
