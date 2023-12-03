using System.ComponentModel.DataAnnotations;

namespace DecoratorDesignPattern.CoreL;



public class ApiResponse
{
    public ApiResponse(bool status, ApiStatusCode statusCode)
    {
        this.status = status;
        if (status)
        {
            Message = "موفق";
        }
        else
        {
            Message = "ناموفق";
        }
        StatusCode = statusCode;
    }

    public bool status { get; }
    public string Message { get; }
    public ApiStatusCode StatusCode { get; }

}

public class ApiResponse<T> : ApiResponse
{
    public T Data { get; }
    public ApiResponse(bool status, ApiStatusCode statusCode, T data) 
        : base(status, statusCode)
    {
        Data = data;
    }
}


public enum ApiStatusCode
{
    [Display(Name = "عملیات موفق بود")]
    Success = 200,
    [Display(Name = "خطا در سرور")]
    ServerError = 500,
    [Display(Name = "پارامترهای ارسالی معتبر نیست")]
    BadRequest = 400,
    [Display(Name = "یافت نشد")]
    NotFound = 404,
    [Display(Name = "اطلاعات تکراری است")]
    DuplicateInformation = 550,
    [Display(Name = "خطای تاریخ")]
    DateTimeError = 515,
    [Display(Name = "لیست خالی می باشد")]
    ListEmpty = 590,
    [Display(Name = "خطای کاربر")]
    UserMistake = 290,

}