from fastapi import FastAPI

app = FastAPI(title="YoMail FastAPI Starter")


@app.get("/")
def home():
    return {"message": "Your FastAPI app is running."}


@app.get("/health")
def health():
    return {"status": "ok"}
