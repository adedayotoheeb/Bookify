using Bookify.Application.Abstractions.Messaging;
using Bookify.Domain.Abstractions;
using Bookify.Domain.Apartments;
using Bookify.Domain.Bookings;
using Bookify.Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Bookings.ReserveBooking
{
    internal sealed class ReserveBookingCommandHandler : ICommandHandler<ReserveBookingCommand, Guid>
    {
        private readonly IUserRepository _userRepository;
        private readonly IApartmentRepository _apartmentRepository;
        private readonly IBookingRepository _bookingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly PricingService _pricingService;

        public ReserveBookingCommandHandler( 
            IUserRepository userRepository,
            IApartmentRepository apartmentRepository, 
            IBookingRepository bookingRepository, 
            IUnitOfWork unitOfWork, 
            PricingService pricingService
            )
        {
            _userRepository = userRepository;
            _apartmentRepository = apartmentRepository;
            _bookingRepository = bookingRepository;
            _unitOfWork = unitOfWork;
            _pricingService = pricingService;
        }

        public async Task<Result<Guid>> Handle(ReserveBookingCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
