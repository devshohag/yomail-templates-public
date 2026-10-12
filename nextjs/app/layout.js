export const metadata = {
  title: "YoMail Next.js Starter",
  description: "A minimal Next.js app hosted on YoMail."
};

export default function RootLayout({ children }) {
  return (
    <html lang="en">
      <body>{children}</body>
    </html>
  );
}
