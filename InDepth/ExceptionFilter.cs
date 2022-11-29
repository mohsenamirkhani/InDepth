using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InDepth
{
    public class ExceptionFilter
    {

        private bool LogAndReturn(string message, bool condition)
        {
            Console.WriteLine(message);
            return condition;
        }

        // Bottom method Would be called from Main Method
        public void Bottom()
        {
            try
            {
                // 1. It would call Middle method
                Middle();
            }

            // 5. the KeyNotFoundException is not the right exception to be catch
            // even the condition won't be executed
            catch (KeyNotFoundException e)
                when (LogAndReturn("Bottom Catch Condition 1", true))
            {
                Console.WriteLine("Middle Exception 1");
            }
            // 6. the Exception type is ok and the condition is also ok
            // so this catch block would be executed 
            // but before that the finally blocks of other Methods in stack must be executed
            catch (Exception ex)
                when (LogAndReturn("Bottom Catch Condition 2", true))
            {

                // 9. after calling all finallies in stack now the bottom exception would be called
                Console.WriteLine("Bottom Exception");
            }

            // 10. at the end of the journey the finally block of the appropriate catch block would be called
            finally
            {
                Console.WriteLine("Bottom Finally");
            }
        }

        // middle method would be called from Bottom method
        private void Middle()
        {
            try
            {
                // 2. it would call Top method
                Top();
            }
            // 4. the Top thrown Exception would come here
            // the exception type in catch block is ok but the condition is false
            // so it would bubble up again to through the stack and to Bottom method
            catch (Exception ex)
                when (LogAndReturn("Middle Catch Condition", false))
            {
                Console.WriteLine("Middle Exception 2");
            }

            // 8. after finally block of Top Method this finally block is next in the stack
            finally
            {
                Console.WriteLine("Middle Finally");
            }
        }

        // Top method would be called form Middle method
        private void Top()
        {
            try
            {
                // 3. it would throw an exception and because this method has no catch block
                // the exception would bubble up the stack and to the Middle method
                throw new Exception();
            }

            // 7. this finally block would execute after catching the Exception by Bottom catch block
            finally
            {
                Console.WriteLine("Top Finally");
            }
        }
    }
}
