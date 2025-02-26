
  

  let tabHeader = document.getElementsByClassName("aipj-tab-header")[0];
  let tabIndicator = document.getElementsByClassName("aipj-tab-indicator")[0];
  let tabBody = document.getElementsByClassName("aipj-tab-body")[0];
  let tabsPane = tabHeader.getElementsByTagName("div");

  for(let i=0;i<tabsPane.length;i++){
    tabsPane[i].addEventListener("click", function()
    {
      tabHeader.getElementsByClassName("active")[0].classList.remove("active");
      tabsPane[i].classList.add("active");
       tabBody.getElementsByClassName("active")[0].classList.remove("active");
       tabBody.getElementsByClassName("div")[i].classList.add("active");

       tabIndicator.style.left = 'calc(calc(100%/4)* ${i})';
    });
  }
