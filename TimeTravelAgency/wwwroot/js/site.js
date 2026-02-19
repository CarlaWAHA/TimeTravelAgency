// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
async function sendChat(){
  const input = document.getElementById("chatText");
  if(!input) return;
  const msg = input.value.trim();
  if(!msg) return;

  appendMsg(msg, "user");
  input.value = "";

  try {
    const response = await fetch("/api/chat", {
      method: "POST",
      headers: { "Content-Type": "application/json" },
      body: JSON.stringify({ message: msg })
    });

    const data = await response.json();
    appendMsg(data.reply, "bot");
  } catch {
    appendMsg("Erreur de connexion au conseiller IA.", "bot");
  }
}
