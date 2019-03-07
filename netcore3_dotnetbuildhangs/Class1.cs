using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary2 {
    public class Class1 {
        class ListItem {
            public ListItem Prev { get; set; }
            public ListItem Next { get; set; }
        }
        void ArrangeNonOverlapping(IList<ListItem> labels) {
            List<ListItem> actualLabels = new List<ListItem>(labels);
            ListItem prev = null;
            ListItem next = null;
            for(int i = 0; i < labels.Count; i++) {
                ListItem label = actualLabels[i];
                label.Prev = prev;
                label.Next = next;
                if(prev != null)
                    prev.Next = label;
                if(next != null)
                    next.Prev = label;
            }
        }
    }
}
