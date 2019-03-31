using AutoMapper;
using userDataManagement.Dtos;
using userDataManagement.ModelsDb;

namespace userDataManagement.Helpers
{
    public class NumberManipulator
    {
        public void swap(ref int x, ref int y) {
         int temp;

         temp = x;
         x = y;    
         y = temp; 
      }
    }
}