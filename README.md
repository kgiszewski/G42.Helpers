# G42.Helpers

Odds and end helpers over the years.

## Flow Control
Run async code syncronously easier with:

```
  var result = AsyncHelper.RunSync(() => foo.SomethingAsync()));
```

## Exceptions
Adds basic exceptions like `NotFoundException` and `ForbiddenException`.

Get inner exception messages by doing the following:

```
try
{
  //kaboom
}
catch(Exception ex)
{
  var allTheExceptionsString = ErrorHelper.GetInnerExceptions(ex);
}
```

## Assembly
Get the version info from assembly meta data.

## Resources
Get an embedded resource as a `string` or `stream` easily.
