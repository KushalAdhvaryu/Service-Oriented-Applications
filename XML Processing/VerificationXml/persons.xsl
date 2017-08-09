<xsl:stylesheet 
  version="1.0" 
  xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">

    <html> <body>
        <h1 style="font-size: 18pt; text-align: center">
         Persons
        </h1>
        <table border="1">
          <tr style="background-color: Grey; font-size: 12pt; font-family: calibri; font-weight: bold">
            <td colspan="2" style="text-align: center">Person</td>
            <td colspan="3" style="text-align: center">Credential</td>
            <td colspan="3" style="text-align: center">Phone</td>
            <td  style="text-align: center">Category</td>
    
          </tr>
		  <tr style="background-color: Yellow; font-size: 12pt; font-family: calibri; font-weight: bold">
            <td  style="text-align: center">First</td>
			<td  style="text-align: center">Last</td>
			<td  style="text-align: center">ID</td>
			<td  style="text-align: center">Password</td>
			<td  style="text-align: center">@Encryption+</td>
			<td  style="text-align: center">Work</td>
			<td  style="text-align: center">Cell</td>
			<td  style="text-align: center">@Provider*</td>
            <td  style="text-align: center">Category</td>
    
          </tr>
          <xsl:for-each select="Persons/Person">
            <xsl:sort select="Person" />
            <tr style="font-size: 12pt; font-family: calibri">
              <td><xsl:value-of select="Name/First"/></td>
              <td>
                <xsl:value-of select="Name/Last"/>
              </td>
              <td>
                <xsl:value-of select="Credential/Id"/>
              </td>
              <td>
                <xsl:value-of select="Credential/Password"/>
              </td>
              <td>
                <xsl:value-of select="Credential/Password/@Encryption"/>
              </td>
              <td>
                <xsl:value-of select="Phone/Work"/>
              </td>
              <td>
                <xsl:value-of select="Phone/Cell"/>
              </td>
			  <td>
                <xsl:value-of select="Phone/Cell/@Provider"/>
              </td>
              <td>
                <xsl:value-of select="Category"/>
              </td>
                  
           </tr>
          </xsl:for-each>
        </table>
      </body> </html>
  </xsl:template>
</xsl:stylesheet>