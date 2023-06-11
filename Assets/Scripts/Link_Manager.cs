using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Link_Manager : MonoBehaviour
{
    public void openLinkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/lance-roller-ii");
    }

    public void openInstagram()
    {
        Application.OpenURL("https://www.instagram.com/");
    }

    public void openTwitter()
    {
        Application.OpenURL("https://twitter.com/");
    }

    public void openGithub()
    {
        Application.OpenURL("https://github.com/LJRollerII");
    }

    public void openDiscord()
    {
        Application.OpenURL("https://discord.com/");
    }

    public void openYoutube()
    {
        Application.OpenURL("https://www.youtube.com/");
    }

    public void openPubmed()
    {
        Application.OpenURL("https://pubmed.ncbi.nlm.nih.gov/?term=lance+roller");
    }
}
