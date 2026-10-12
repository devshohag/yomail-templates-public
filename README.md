# YoMail public app templates

Each top-level directory is a small starter application and contains a `template.json`
read by YoMail's pinned hosting catalog. The catalog metadata describes the runtime,
preset, managed data services, and environment variables that YoMail must supply.

Secrets are never included in these templates. Secret variables are declared by name
only and must be generated or provisioned by YoMail.
