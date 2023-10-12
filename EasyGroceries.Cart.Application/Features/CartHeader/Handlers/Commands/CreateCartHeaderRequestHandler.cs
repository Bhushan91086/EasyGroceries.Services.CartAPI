﻿using AutoMapper;
using EasyGroceries.Cart.Application.Contracts.Infrastructure;
using EasyGroceries.Cart.Application.DTOs;
using EasyGroceries.Cart.Application.Features.CartHeader.Requests.Commands;
using EasyGroceries.Cart.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyGroceries.Cart.Domain;

namespace EasyGroceries.Cart.Application.Features.CartHeader.Handlers.Commands
{
    public class CreateCartHeaderRequestHandler : IRequestHandler<CreateCartHeaderRequest, ResponseDto<CartHeaderDto>>
    {
        private readonly ICartHeaderRepository _cartHeaderRepository;
        private readonly IMapper _mapper;

        public CreateCartHeaderRequestHandler(ICartHeaderRepository cartHeaderRepository, IMapper mapper)
        {
            _cartHeaderRepository = cartHeaderRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CartHeaderDto>> Handle(CreateCartHeaderRequest request, CancellationToken cancellationToken)
        {
            var response = new ResponseDto<CartHeaderDto>();
            var cartHeader = _mapper.Map<EasyGroceries.Cart.Domain.CartHeader>(request.CartHeaderDto);
            cartHeader = await _cartHeaderRepository.Add(cartHeader);
            response.Message = "CartHeader Creation Successful";
            response.Result = request.CartHeaderDto;
            return response;
        }
    }
}