using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ringBuffer : IDisposable
{
    public void Dispose()
    {

    }

    public int MAX_QUEUE_SIZE = 4096;
	public byte[] ring_buf = new byte[4096]; // ring buffer
    public int ring_buf_len = 0; // ring buffer length
    public int ring_buf_head = 0;
    public int ring_buf_tail = 0;

    public bool bstart_pkt = false;

	//public object key = new object();

    public void ring_buffer_push(byte data)
    {
		int temp;
		//lock (key)
		{
			temp = (ring_buf_head + 1) % MAX_QUEUE_SIZE;
			if (temp == ring_buf_tail) return;

			ring_buf[ring_buf_head++] = data;
			ring_buf_len++;

			if (temp != ring_buf_tail) ring_buf_head = temp;
		}
    }

    public byte ring_buffer_pop()
    {
		byte ret = 0;

		//lock (key)
		{
			if (ring_buf_head == ring_buf_tail) return 0;

			ret = ring_buf[ring_buf_tail++];
			ring_buf_tail %= MAX_QUEUE_SIZE;
			ring_buf_len--;
		}        
        return ret;
    }

	public int ring_buffer_length()
	{
		int length;
		//lock (key)
		{
			length = (ring_buf_head - ring_buf_tail + MAX_QUEUE_SIZE) % MAX_QUEUE_SIZE;
		}
		return length;
    }

    public void ring_buffer_init()
    {
		ring_buf_head = 0;
		ring_buf_tail = 0;
        ring_buf_len = 0;
    }


}
