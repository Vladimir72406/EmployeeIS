using EmployeeIS.DataBase;
using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeIS.Logic
{
    class ManagerAddress
    {
        IDataBase dba;
        public ManagerAddress()
        {
            dba = InstanceDB.getInstance();
        }
        public Result saveAddress(Address address)
        {
            Result result = new Result();
            if (address.address_id > 0)
            {
                try
                {
                    result = dba.updateAddress(address);
                }
                catch (Exception e)
                {
                    result.hasError = true;
                    result.error = e.Message.ToString();
                }
            }
            else
            {
                try
                {
                    result = dba.insertAddress(address);
                }
                catch (Exception e)
                {
                    result.hasError = true;
                    result.error = e.Message.ToString();
                }
            }

            return result;
        }

        public Address getAddressById(int _address_id)
        {
            return dba.getAddressByID(_address_id);
        }

        public Result deleteAddress(int _address_id)
        {
            Result result = new Result();
            try
            {
                result = dba.deleteAddress(_address_id);
            }
            catch (Exception e)
            {
                result.error = e.Message.ToString();
                result.hasError = true;
            }
            return result;
        }

        public List<Address> getListAddressByCorporationId(int _corporation_id)
        {
            return dba.getListAddressByCorporationID(_corporation_id);
        }
    }
}
