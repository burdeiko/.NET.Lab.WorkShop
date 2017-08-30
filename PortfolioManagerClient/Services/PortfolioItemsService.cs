using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using PortfolioManagerClient.Models;
using PortfolioManager.Service.Models;
using System.Linq;
using PortfolioManagerClient.Infrastructure;
using PortfolioManager.Service.Interfaces;
using System;

namespace PortfolioManagerClient.Services
{
    /// <summary>
    /// Works with portfolio backend.
    /// </summary>
    public class PortfolioItemsService
    {
        private readonly IService service;

        /// <summary>
        /// Creates the service.
        /// </summary>
        public PortfolioItemsService(IService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Gets all portfolio items for the user.
        /// </summary>
        /// <param name="userId">The User Id.</param>
        /// <returns>The list of portfolio items.</returns>
        public IList<PortfolioItemViewModel> GetItems(int userId)
        {
            return service.GetAll().Select(item => item.ToViewModel()).ToList();
        }

        /// <summary>
        /// Creates a portfolio item. UserId is taken from the model.
        /// </summary>
        /// <param name="item">The portfolio item to create.</param>
        public void CreateItem(PortfolioItemViewModel item)
        {
            try
            {
                service.Add(item.ToBLLModel());
            }
            catch (Exception e)
            {
                //TODO add error handling
            }
        }

        /// <summary>
        /// Updates a portfolio item.
        /// </summary>
        /// <param name="item">The portfolio item to update.</param>
        public void UpdateItem(PortfolioItemViewModel item)
        {
            try
            {
                service.Update(item.ToBLLModel());
            }
            catch (Exception e)
            {
                //TODO add error handling
            }
        }

        /// <summary>
        /// Deletes a portfolio item.
        /// </summary>
        /// <param name="id">The portfolio item Id to delete.</param>
        public void DeleteItem(int id)
        {
            try
            {
                service.Delete(id);
            }
            catch (Exception e)
            {
                //TODO add error handling
            }
        }
    }
}
