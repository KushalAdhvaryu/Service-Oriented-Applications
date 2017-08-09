using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace eCommerce
{
    class MultiCellBuffer
    {
        //Creating Data structure for cell.
        struct Cell
        {
            public string order;
        }

        //Intialize array of Cell for Multicell Buffer.
        private Cell[] buffer;
        
        //Number of cells in multi cell buffer set to 2.
        const int size = 2;

        //Counter to handle multicell buffer value to be filled.
        int counter = 0;

        //Constructor for Multicell buffer. Setting order strings to Null for both cells.
        public MultiCellBuffer()
        {
            buffer = new Cell[size];
            //Currently none of the cell are filled.
            counter = 0;
            //Setting order strings to Null for both cells.
            for (int i = 0; i < size; i++)
            {
                buffer[i].order = "";
            }
        }

        //When write mode access to MulticellBuffer will not be allowed since its non overlapping operaiton hence setting semaphore full.
        Semaphore write = new Semaphore(2, 2);
        //When read mode its overlapping operation so allowing semaphore to be 0.
        Semaphore read = new Semaphore(0, 2);

        //Implemenation fo setting a cell value mechanism.
        public void setOneCell(String input)
        {
            //WaitOne to occupy resource.
            write.WaitOne();
            //Increment cell value to be filled.
            this.counter++;
            //Lock the particular cell in multicellbuffer.
            lock (buffer[this.counter - 1].order)
            {
                //Set value of string to multicell buffer.
                buffer[this.counter - 1].order = input;
                //Release lock.
                read.Release();
            }
        }

        //Implementation of getting a cell value mechanism.
        public String getOneCell()
        {
            //WaitOne to occupy resource to read.
            read.WaitOne();
            //Decrement counter since cell will now be read.
            this.counter--;
            // Lock the cell in buffer to read the value.
            lock (buffer[this.counter].order)
            {
                // Read the buffer cell value into a string for return.
                string value = buffer[this.counter].order;
                //Release the lock.
                write.Release();
                return value;
            }
        }
    }
}
