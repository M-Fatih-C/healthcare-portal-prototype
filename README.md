# Healthcare Portal UI Prototype

An ASP.NET Core MVC/Razor interface prototype showing healthcare landing pages,
a doctor dashboard and registration/login layouts. The recovered project includes
minimal local view-model placeholders; it is not a working patient-management,
authentication or healthcare backend product.

## Source and setup

`Program.cs` configures MVC and static files. `Controllers/`, `Models/`, `Views/`
and `wwwroot/` retain the original project layout. The single
`panel_new.PresentationLayer.csproj` currently targets **net6.0**.

In an isolated development environment with the matching SDK/runtime:

```bash
dotnet restore
dotnet build
dotnet run
```

Use the local URL printed by ASP.NET. A .NET SDK was not available in the audit
environment, so restore/build/runtime success is not claimed. Microsoft support
for .NET 6 ended on 12 November 2024; a supported-LTS migration and regression
checks are required before considering deployment. That migration is outside
this documentation change.

## Prototype limitations

Registration currently renders a view; it does not create a secured account.
The startup code calls authentication middleware without a configured full
authentication service. The old data/business layers are not included. Real
authentication, authorization, validated persistence and server-side workflows
would need explicit implementation and tests. No automated test suite is present.

Use synthetic interface content only. Do not upload patient records, configure a
real hospital backend, or expose this prototype as a secured service. The source
scan did not identify committed patient-data files, but that is not a complete
privacy or security certification.

## License and author

No license file is included; no new license grant is asserted. Author: [Muhammet Fatih Çetintaş](https://github.com/M-Fatih-C).
