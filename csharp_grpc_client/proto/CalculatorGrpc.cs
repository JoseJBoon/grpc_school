// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: calculator.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Calculator {
  public static partial class Calculate
  {
    static readonly string __ServiceName = "calculator.Calculate";

    static readonly grpc::Marshaller<global::Calculator.IntRequest> __Marshaller_calculator_IntRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Calculator.IntRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Calculator.IntResponse> __Marshaller_calculator_IntResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Calculator.IntResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Calculator.IntRequest, global::Calculator.IntResponse> __Method_Add = new grpc::Method<global::Calculator.IntRequest, global::Calculator.IntResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Add",
        __Marshaller_calculator_IntRequest,
        __Marshaller_calculator_IntResponse);

    static readonly grpc::Method<global::Calculator.IntRequest, global::Calculator.IntResponse> __Method_Mul = new grpc::Method<global::Calculator.IntRequest, global::Calculator.IntResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Mul",
        __Marshaller_calculator_IntRequest,
        __Marshaller_calculator_IntResponse);

    static readonly grpc::Method<global::Calculator.IntRequest, global::Calculator.IntResponse> __Method_Pow = new grpc::Method<global::Calculator.IntRequest, global::Calculator.IntResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Pow",
        __Marshaller_calculator_IntRequest,
        __Marshaller_calculator_IntResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Calculator.CalculatorReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Calculate</summary>
    public abstract partial class CalculateBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Calculator.IntResponse> Add(global::Calculator.IntRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Calculator.IntResponse> Mul(global::Calculator.IntRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Calculator.IntResponse> Pow(global::Calculator.IntRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Calculate</summary>
    public partial class CalculateClient : grpc::ClientBase<CalculateClient>
    {
      /// <summary>Creates a new client for Calculate</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CalculateClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Calculate that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CalculateClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CalculateClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CalculateClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Calculator.IntResponse Add(global::Calculator.IntRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Add(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Calculator.IntResponse Add(global::Calculator.IntRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Add, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Calculator.IntResponse> AddAsync(global::Calculator.IntRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AddAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Calculator.IntResponse> AddAsync(global::Calculator.IntRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Add, null, options, request);
      }
      public virtual global::Calculator.IntResponse Mul(global::Calculator.IntRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Mul(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Calculator.IntResponse Mul(global::Calculator.IntRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Mul, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Calculator.IntResponse> MulAsync(global::Calculator.IntRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MulAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Calculator.IntResponse> MulAsync(global::Calculator.IntRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Mul, null, options, request);
      }
      public virtual global::Calculator.IntResponse Pow(global::Calculator.IntRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Pow(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Calculator.IntResponse Pow(global::Calculator.IntRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Pow, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Calculator.IntResponse> PowAsync(global::Calculator.IntRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PowAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Calculator.IntResponse> PowAsync(global::Calculator.IntRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Pow, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CalculateClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CalculateClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CalculateBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Add, serviceImpl.Add)
          .AddMethod(__Method_Mul, serviceImpl.Mul)
          .AddMethod(__Method_Pow, serviceImpl.Pow).Build();
    }

  }
}
#endregion