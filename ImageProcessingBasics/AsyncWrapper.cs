using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace ImageProcessingBasics
{
    class AsyncWrapper
    {
        public static void WrapSync(Task task)
        {
            Task newTask = Task.Factory.StartNew(async () => await task, TaskCreationOptions.LongRunning);
            newTask.ContinueWith((t) => {
                if (t.Exception != null)
                {
                    Program.Form.appendLog("Async wrapper faulted with exception:");
                    t.Exception.ToString().Split(new char[] { '\n' }).ToList().ForEach(s => Program.Form.appendLog(s));
                }
                else Program.Form.appendLog("Async wrapper faulted without exception.");

            }, TaskContinuationOptions.OnlyOnFaulted);
        }

        public async static Task<Bitmap> Wrap(Func<Bitmap> func)
        {
            return await Task<Bitmap>.Factory.StartNew(() => func(), TaskCreationOptions.LongRunning);
        }
    }
}
