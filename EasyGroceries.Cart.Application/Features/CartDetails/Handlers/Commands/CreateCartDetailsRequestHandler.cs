using AutoMapper;
using EasyGroceries.Cart.Application.Contracts.Infrastructure;
using EasyGroceries.Cart.Application.DTOs;
using EasyGroceries.Cart.Application.Features.CartDetails.Requests.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyGroceries.Cart.Application.Features.CartDetails.Handlers.Commands
{
    public class CreateCartDetailsRequestHandler : IRequestHandler<CreateCartDetailsRequest, ResponseDto<CartDetailsDto>>
    {
        private readonly ICartDetailsRepository _cartDetailsRepository;
        private readonly IMapper _mapper;

        public CreateCartDetailsRequestHandler(ICartDetailsRepository cartDetailsRepository, IMapper mapper)
        {
            _cartDetailsRepository = cartDetailsRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CartDetailsDto>> Handle(CreateCartDetailsRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseDto<CartDetailsDto>();
            var cartDetails = _mapper.Map<EasyGroceries.Cart.Domain.CartDetails>(request.CartDetailsDto);
            cartDetails = await _cartDetailsRepository.Add(cartDetails);
            response.Message = "CartDetails Creation Successful";
            response.Result = request.CartDetailsDto;
            return response;
        }
    }
}
