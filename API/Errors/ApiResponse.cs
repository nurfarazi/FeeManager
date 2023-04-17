﻿namespace API.Errors;

public class ApiResponse
{
    public ApiResponse(int statusCode, string message = null)
    {
        StatusCode = statusCode;
        Message = message ?? GetDefaultMessageForStatusCode(statusCode);
    }

    public int StatusCode { get; set; }
    public string Message { get; set; }

    private static string GetDefaultMessageForStatusCode(int statusCode)
    {
        return statusCode switch
        {
            400 => "A bad request, you have made",
            401 => "Authorized, you are not",
            403 => "You are not allowed to make this request",
            404 => "Resource found, it was not",
            500 =>
                "Errors are the path to the dark side. Errors lead to anger. Anger leads to hate. Hate leads to career change",
            405 => "Method not allowed, Does not exist",
            _ => null
        };
    }
}